from http.server import BaseHTTPRequestHandler, HTTPServer

class handler(BaseHTTPRequestHandler):
    def do_GET(self):
        self.send_response(200)
        self.send_header('Content-type','text/html')
        self.end_headers()

        message = "Hello, World!"
        self.wfile.write(bytes(message, "utf8"))
        
    def do_POST(self):
        message = "Hello, World!"
        self.wfile.write(bytes(message, "utf8"))
        
with HTTPServer(('', 80), handler) as server:
    server.serve_forever()
