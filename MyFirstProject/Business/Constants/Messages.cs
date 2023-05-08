using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //temel mesajları barındırır
    public static class Messages
    {
        //static olduğunda new'lenmez direkt . ile verilir sabit tutmak için yaptık
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";

        public static string UserNotFound = "Kullanıcı bulunmadı";
        public static string UserLogin = "Giriş Başarılı";
        public static string PasswordError = "Şifre Hatalı";

        public static string UserRegistered = "Kayıt Başarılı";

        public static string AssessmentBookAddSuccess = "Değerlendirme Kaydı Başarılı";
        public static string AssessmentBookDeleteSuccess = "Değerlendirme Kayıt silme Başarılı";
        public static string AssessmentBookUpdateSuccess = "Değerlendirme Günceleme Başarılı";




    }
}
