﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

            List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLoggerService, smsLoggerService };
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            basvuruManager.BasvuruYap(esnafKrediManager, loggerServices);

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
