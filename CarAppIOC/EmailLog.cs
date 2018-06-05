using System;

namespace CarAppIOC
{
    public class EmailLog : ILog
    {
        public void Write(string message)
        {
            var admin = "admin@app.com";

            Console.WriteLine($"Email sent to {admin} : {message}");
        }
    }
}
