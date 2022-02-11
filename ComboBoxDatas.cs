using System.Collections.Generic;

namespace KriptolojiTez
{
    public static class ComboBoxDatas
    {
        //----Dosya Tipleri----
        public static string tip1 = ".rar";
        public static string tip2 = ".zip";
        public static string tip3 = ".txt";
        public static string tip4 = ".docx";
        public static string tip5 = ".pdf";

        //----Hash Tipleri-----
        public static string hash1 = "SHA1";
        public static string hash2 = "SHA256";
        public static string hash3 = "SHA384";
        public static string hash4 = "SHA512";

        public static IList<string> getFileTypesForRSA()
        {
            return new List<string> { tip1,tip2, tip3, tip4, tip5 };
        }

        public static IList<string> getFileTypesForDSA()
        {
            return new List<string> { tip1, tip2, tip3, tip4, tip5 };
        }

        public static IList<string> getFileTypesForECDsaCNG()
        {
            return new List<string> { tip1, tip2, tip3, tip4, tip5 };
        }

        public static IList<string> getHashTypesForRSA()
        {
            return new List<string> { hash2, hash3, hash4 };
        }

        public static IList<string> getHashTypesForDSA()
        {
            return new List<string> { hash1};
        }

        public static IList<string> getHashTypesForECDsaCNG()
        {
            return new List<string> { hash2, hash3, hash4 };
        }
    }
}
