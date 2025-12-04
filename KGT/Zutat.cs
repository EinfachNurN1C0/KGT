using System.Threading.Tasks;

namespace KGT
{
    abstract internal class Zutat
    {
        protected int menge;
        protected int produktionszeit;
        protected async void Zubereiten()
        {
            await Task.Delay(produktionszeit);
            menge++;
        }
    }
}
