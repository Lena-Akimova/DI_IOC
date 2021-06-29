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
    class SheduleManager
    {
        public Shedule GetShedule()
        {
            //
            return new Shedule();
        }
    }
    /// <summary>
    /// Для отображения расписания
    /// </summary>
    class SheduleViewer
    {
        SheduleManager man = new SheduleManager();

        public void ViewShadule()
        {
            man.GetShedule();
        }
    }



}
