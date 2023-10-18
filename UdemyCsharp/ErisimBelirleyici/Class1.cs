namespace ErisimBelirleyici
{
    public class sekil
    {
        /*
         nesne örneği üzerinden ulaşılamaz. Hem kendi assembylisinden hemde
        farklı projelerden ulaşılabilir.
         */
        protected string ProtectedVeri { get; set; }

        /*
         * nesne örneği üzerinden de ulaşılabilir üsttekine ek olarak
         */
        protected internal string ProtectedInternalVeri { get; set; }

        /*
         * sadece kendi assemblysinde nesne örneği alınmadan ulaşılabilir.
         */
        private protected string PrivateProtectedVeri { get; set; }


    }
    public class Ucgen : sekil
    {
        private void hesapla()
        {
            
            
        }
    }
}