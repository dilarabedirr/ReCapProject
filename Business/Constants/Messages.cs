using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi.";
        public static string CarInvalid = "Araba Ekleme işlemi başarısız.";
        public static string CarsListed = "Arabalar Listelendi.";

        public static string MaintenanceTime = "Sistem bakımda..";

        public static string ColorAdded = "Renk Eklendi.";

        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UsersListed = "Kullanıcılar Listelendi";

        public static string CustomerAdded = "Müşteri Eklendi.";
        public static string CustomersListed = "Müşteriler Listelendi";

        public static string RentalAdded = "Kiralama Bilgisi Eklendi.";
        public static string RentalsListed = "Listeleme başarılı";

        public static string CarImageAdded = "Fotoğraf Eklendi.";
        public static string CarImageInvalid = "Fotoğraf ekleme işlemi başarısız";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
