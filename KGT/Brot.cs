using System.Threading.Tasks;

namespace KGT
{
    internal class Brot : Zutat
    {
        public override async void Zubereiten()
        {
            await Task.Delay(produktionszeit);
        }
    }
}
