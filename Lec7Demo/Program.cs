using System;

namespace Lec7Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var temperatureObserver = new TemperatureObserver();
            var temperatureObservable = new TemperatureObservable();
            temperatureObserver.Subscribe(temperatureObservable);
            temperatureObservable.Measure(-1);
            temperatureObservable.Measure(-2);
            temperatureObservable.Measure(-3);

            Console.ReadKey();
        }

        class TemperatureObservable : IObservable<Temperature>
        {
            IObserver<Temperature> observer;

            public IDisposable Subscribe(IObserver<Temperature> observer)
            {
                this.observer = observer;
                return null;
            }

            public void Measure(int value)
            {
                observer.OnNext(new Temperature() { Degrees = value, Time = DateTime.Now });
            }
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold was reached");
            Console.WriteLine($"Threshold: {e.Threshold}");
            Console.WriteLine($"TimeReached: {e.TimeReached}");
        }
    }
}
