using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject
{
    static class CounterConfig
    {
        public static CounterViewModel ViewModel { get; set; } 
        static CounterConfig()
        {

        ViewModel = new CounterViewModel(); }
    }

 }
