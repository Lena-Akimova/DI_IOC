using System;

namespace DI_IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
        }
    }



}
