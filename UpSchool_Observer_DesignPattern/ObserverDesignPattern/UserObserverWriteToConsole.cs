using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using UpSchool_Observer_DesignPattern.DAL;

namespace UpSchool_Observer_DesignPattern.ObserverDesignPattern
{
    public class UserObserverWriteToConsole : IUserObserver
    {
        //gözlemele işini logunu konsola yazacak
        private IServiceProvider _serviceProvider;
        //loglama her sınıf için ayrı ayrı yazıldığı için ServiceProvider
        //dependency injection ile verilir.

        public UserObserverWriteToConsole(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateUser(AppUser appUser)
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<UserObserverWriteToConsole>>(); //Logger loglama işlemleri için kullanılır. Yani yapılan işlemlerinin kaydının tutulmasını sağlar
                                                                                                     //Burada GetRequiredService kategori adı olarak üzerinde çalıştığım sınıfı alır. Burada kategori ismi üzerinde loglama yapacağım sınıftır. Yani nereye loglayacağım olur.
            logger.LogInformation($"{appUser.Name+" "+appUser.Surname} isimli" +
                $"kullanıcı sisteme kaydoldu.");//loglama ile ilgili bana bilgi verir.
            //bana kullanıcı sisteme kaydolduğunda bu mesajı fırlatıcak
            //Yani logları konsola yazsın.

        }
    }
}
