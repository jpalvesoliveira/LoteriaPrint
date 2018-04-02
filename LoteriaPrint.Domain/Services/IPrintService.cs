using LoteriaPrint.Domain.Model;

namespace LoteriaPrint.Domain.Services
{
    public interface IPrintService
    {
        void Print(Bilhete bilhete);
    }
}
