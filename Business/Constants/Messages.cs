using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarNameInvalid = "Araba ismi geçersiz"; 
        public static string CarPriceInvalid = "Araba kira ücreti  0'dan büyük olmalı";
        public static string CarListed = "Arabalar listelendi";
        public static string CarDetailsListed = "Araba detayları listelendi";
        public static string CarNotAvailable = "Araba başka bir müşteri tarafından kiralandı";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandListed = "Markalar listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorListed = "Renkler listelendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı bilgileri güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserInformationInvalid = "Kullanıcı ismi geçersiz";
        public static string UserListed = "Kullanıcılar listelendi";

        public static string RentalAdded = "Araç kiralandı";
        public static string RentalUpdated = "Kiralama bilgileri güncellenddi";
        public static string RentalDeleted = "Kiralama işlemi silindi";
        public static string RentalNotReturn = "Kiralık araç geri dönmedi";
        public static string RentalListed = "Kiralık araçlar listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi";
        public static string CustomerDeleted = "Müşteri bilgileri silindi";
        public static string CustomerListed = "Müşteriler listelendi";


        public static string MaintenanceTime = "Sistem bakımda";

        public static string FailedCarImageAdd = "Bir aracın en 5'ten fazla fotoğrafı olamaz";
        public static string CarImageAdded = "Araç fotoğrafı eklendi";
        public static string CarImageDeleted = "Araç fotoğrafı silindi";
        public static string CarImagesListed = "Fotoğraflar listelendi";
        public static string CarImageUpdated = "Fotoğraflar güncellendi";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt başarılı.";

        public static string UserNotFound = "Kullanıcı bulunamadı.";

        public static string PasswordError = "Şifre hatalı!";
        public static string SuccessfulLogin = "Giriş başarılı!";
        public static string UserAlreadyExists = "Kullanıcı mevcut. ";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
