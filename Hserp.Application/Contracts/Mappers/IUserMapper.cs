using Hserp.Application.Contracts.Mapper;
using Hserp.Application.HsUsers.ViewModels.User;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Mappers
{
    public interface IUserMapper : IMapper
    {
        HsUser ToEntity(UserRegisterVM registerVM);
        UserVM ToViewModel(HsUser user);
    }
}



//HsUser ToEntity(UserRegisterVM registerVM)

//Bu yöntem, UserRegisterVM tipinden bir nesne alır ve HsUser tipinden bir nesne döndürür.
//Bu yöntem, UserRegisterVM nesnesini HsUser varlık nesnesine dönüştürmek için kullanılır.
//registerVM parametresi, dönüşüm işlemi için gerekli verileri içeren kullanıcı kayıt görüntü modelini temsil eder.
//UserVM ToViewModel(HsUser user)

//Bu yöntem, HsUser tipinden bir nesne alır ve UserVM tipinden bir nesne döndürür.
//Bu yöntem, HsUser varlık nesnesini UserVM görüntü modeline dönüştürmek için kullanılır.
//user parametresi, dönüşüm işlemi için gerekli verileri içeren kullanıcı varlık nesnesini temsil eder.
//Bu arabirim, UserMapper sınıfında tanımlanan yöntemleri içerir. Arabirim, UserMapper sınıfının bu yöntemleri uygulamasını sağlar ve bu sayede IUserMapper arabirimini uygulayan herhangi bir sınıf, aynı yöntemleri tanımlamak zorunda kalır. Bu, kodun yeniden kullanılabilirliğini artırır ve farklı sınıflar arasında dönüşüm işlemlerinin tutarlı bir şekilde gerçekleştirilmesini sağlar. Ayrıca, bağımlılıkları azaltmak için bu arabirim, başka bir sınıf tarafından kullanılabilecek bir bileşenin arayüzünü belirtmek için de kullanılabilir.