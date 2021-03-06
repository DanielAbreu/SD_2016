﻿using ISuper;
using System;
using System.Configuration;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace Zone
{
    public class Program
    {
        static int port
        {
            get
            {

                if (ConfigurationManager.AppSettings["port"] == null)
                {
                    throw new ArgumentNullException("Key port not present in App.config");
                }
                return Int32.Parse(ConfigurationManager.AppSettings["port"]);
            }
        }

        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Zone.exe.config", false);
            Console.WriteLine("Waiting Requests on port: "+port);
            Console.ReadLine();
        }
    }
}
