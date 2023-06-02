using Hserp.Application.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.ViewModels.User;


//record anahtar kelimesi: record, C# 9.0'da tanıtılan bir özelliktir ve "davranışsız veri" sınıflarının hızlı bir şekilde oluşturulmasına izin verir. record sınıfları, doğrusal eşitlik, kopyalama, koddaki değişiklikleri izleme gibi özelliklere otomatik olarak sahiptir. Bu özellikler, veri transferi ve değişimi gibi senaryolarda sıklıkla kullanılır.

//UserVM, "User View Model" (Kullanıcı Görünüm Modeli) anlamına gelir. Bu yapı, genellikle kullanıcı arayüzü (UI) ile etkileşimde bulunan ve UI üzerindeki verileri temsil eden bir sınıftır.


public record UserVM(Guid id, string username, string email) : IViewModel;
