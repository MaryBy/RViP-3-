using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Server
{
    class Metod
    {
        ConcurrentBag<string> cb_speed = new ConcurrentBag<string>();
        ConcurrentBag<string> cb_count = new ConcurrentBag<string>();
        string rt1 ="";
        string rt2 = "";
        public int name;
        public Metod(int _name)
        {
            name = _name;
        }    
        public string Get_info()
        {
            rt1="Сервер-"+name.ToString()+ " принимает запрос";
            return rt1;
        }
        public string Och()
        {
            rt2 = "Постановка сообщения в очередь";
            Thread.Sleep(5);
            return rt2;
        }
        
    }
}
