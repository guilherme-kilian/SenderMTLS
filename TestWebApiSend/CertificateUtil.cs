using System.Security.Cryptography.X509Certificates;

namespace TestWebApiSend
{
    public static class CertificateUtil
    {
        private const string CertifcatePath = "./App_Data/root_test2.pfx";
        public static X509Certificate2 GetCertificate() => new(CertifcatePath, "1234");
    }
}
