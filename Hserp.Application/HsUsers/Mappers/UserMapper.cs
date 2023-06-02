using Hserp.Application.Contracts;
using Hserp.Application.Contracts.Mappers;
using Hserp.Application.HsUsers.ViewModels.User;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Mappers;

public class UserMapper : IUserMapper
{
    public HsUser ToEntity(UserRegisterVM registerVM)
        => new HsUser
        {
            Id = Guid.NewGuid(),
            Username = registerVM.username,
            Email = registerVM.email,
            Password = registerVM.password,
            CreateDate = DateTime.Now
        };

    public UserVM ToViewModel(HsUser user)
        => new UserVM(user.Id, user.Username, user.Email);

}

//UserMapper sınıfı IUserMapper arabirimini uygulamaktadır.Bu, UserMapper sınıfının IUserMapper arabiriminde tanımlanan tüm yöntemleri uygulayacağı anlamına gelir.

//ToEntity yöntemi, UserRegisterVM tipinden bir nesne alır ve HsUser tipinden bir nesne döndürür.Bu yöntem, registerVM parametresini kullanarak HsUser nesnesinin özelliklerini doldurur.

//ToEntity yöntemi içindeki kod parçası new HsUser ifadesiyle yeni bir HsUser nesnesi oluşturur.Bu nesneye Id, Username, Email, Password ve CreateDate özellikleri atanır.Id özelliği Guid.NewGuid() kullanılarak benzersiz bir kimlik oluşturulur.Username, Email ve Password özellikleri registerVM parametresinin ilgili özelliklerinden alınır.CreateDate özelliği ise DateTime.Now kullanılarak anlık tarih ve saat olarak atanır.

//ToViewModel yöntemi, bir HsUser nesnesi alır ve UserVM tipinden bir nesne döndürür. Bu yöntem, user parametresini kullanarak UserVM nesnesinin özelliklerini doldurur.

//ToViewModel yöntemi içindeki kod parçası new UserVM ifadesiyle yeni bir UserVM nesnesi oluşturur.Bu nesneye Id, Username ve Email özellikleri atanır.Bu özellikler, user parametresinin ilgili özelliklerinden alınır.

//Bu yapı, UserRegisterVM adlı bir görüntü modeli (view model) ve HsUser adlı bir varlık sınıfı arasında dönüşüm işlemlerini gerçekleştirir. ToEntity yöntemi, UserRegisterVM nesnesini HsUser varlık nesnesine dönüştürürken, ToViewModel yöntemi HsUser varlık nesnesini UserVM görüntü modeline dönüştürür. Bu yapı, uygulama katmanlarında veri aktarımını kolaylaştırmak için kullanılabilir, örneğin veri erişim katmanında veri tabanı varlık sınıfları ile kullanıcı arayüzünde görüntü modelleri arasında dönüşümler yaparken kullanılabilir.