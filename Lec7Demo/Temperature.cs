using System;
using System.Collections.Generic;
using System.Text;

namespace Lec7Demo
{
    class Temperature
    {
        // значение температуры в градусах
        public float Degrees { get; set; }
        // время измерения
        public DateTime Time { get; set; }
    }

    class TemperatureObserver : IObserver<Temperature>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Измерение температуры завершено");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Произошла ошибка");
        }

        public void OnNext(Temperature value)
        {
            Console.WriteLine($"Темпаратура: {value.Degrees}, время: {value.Time}");
        }

        private IDisposable disposable;

        public void Subscribe(IObservable<Temperature> provider)
        {
            disposable = provider.Subscribe(this);
        }

        public void Unsubscribe()
        {
            disposable.Dispose();
        }
    }
}
