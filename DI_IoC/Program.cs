using Ninject;
using Ninject.Modules;
using System;
using System.Numerics;
using System.Threading;

namespace DI_IoC
{
    class Program
    {
        /// <summary>
        /// создаем нинжект контеинер передаем конфигурацию
        /// теперь при создании шедулвью нужный привязанный экземпляр интерфейса менеджера будет подставлен в констр вью
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //SheduleViewer view = new SheduleViewer(new SheduleManager());
            //view.ViewShadule();
            BigInteger i = 0;
            while (i <= 89458)
            { Console.WriteLine(i);
                i++;
            }

            
            IKernel kernel = new StandardKernel(new ConfigModule());
            SheduleViewer view = kernel.Get<SheduleViewer>();
            view.ViewShadule();
        }
    }

    class Shedule
    {
        public string Day { get; set; }
        public string Lesson { get; set; }
    }

    /// <summary>
    /// Хотим создать расписание 
    /// </summary>

    interface ISHeduleManager
    {
        Shedule GetShedule();
    }

    class SheduleManager:ISHeduleManager
    {
        /// <summary>
        /// Создание расписания осоюого вида
        /// </summary>
        /// <returns></returns>
        public Shedule GetShedule()
        {
            
            return new Shedule();
        }
    }
    /// <summary>
    /// Для отображения расписания 
    /// Если поменяется код менеджера или появится много разных менеджеров 
    /// чтобы не надо было менять вьюер тоже
    /// </summary>
    class SheduleViewer
    {
        private ISHeduleManager _man;

        /// <summary>
        /// Constructor injection
        /// </summary>
        /// <param name="man">Конкретная реализация менеджера</param>
        public SheduleViewer(ISHeduleManager man)
        {
            _man = man;
        }

        public void ViewShadule()
        {
            _man.GetShedule();
            Console.WriteLine("Отображенеи расписания типа "+ _man.GetType());
        }
    }
    /// <summary>
    /// везде где нужен айшедул менеджер будет поставляться через контейнер этот шедул мжнеджер
    /// </summary>
    class ConfigModule: NinjectModule
    {
        public override void Load()
        {
            Bind<ISHeduleManager>().To<SheduleManager>();
            Bind<SheduleViewer>().ToSelf();
        }
    }





}
