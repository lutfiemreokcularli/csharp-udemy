namespace Matematik
{
    public class Islem
    {
        /*
         Public veri kendi assemblysi dışında diğer
        projelerde de görülür
         */
        public string PublicVeri { get; set; }

        /*
         internal veri kendi assemblysinde görünür sadece. Başka projelere de eklense
        bu class library diğer projelerde bu değişkne görülmez.
         */
        internal int InternalVeri { get; set; }

        private int PrivateVeri { get; set; }
   
        void hesapla()
        {

        }
    }
    public class Islem2
    {
        void hesapla() { 
            Islem i = new Islem();
        }
    }
}