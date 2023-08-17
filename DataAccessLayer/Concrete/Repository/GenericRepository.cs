using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class //alacagı t değeri bir class olmalı
    {
        //  t değerine denk gelen sınıfı tutuyor _object

        Context c = new Context(); //Bu satır, Entity Framework ile veritabanı işlemleri yapmak için bir DbContext nesnesi olan "context" adında bir değişken oluşturur ve bunu "c" adıyla tanımlar. "context", genellikle veri tabanıyla etkileşime geçmek için kullanılan DbContext sınıfından miras alınır ve veri tabanı bağlantısını ve veri sorgularını yönetir.
        DbSet<T> _object; //Bu satır, dışarıdan aldıgım değere erişim sağlamak için "T" tipinde bir DbSet nesnesi olan "_object" adında bir değişken tanımlar. DbSet sınıfı, Entity Framework ile veritabanı tablolarına erişim sağlayan koleksiyonları temsil eder.



        public GenericRepository()
        {
            _object = c.Set<T>();  //DbSet<T> nesnesi, GenericRepository sınıfı oluşturulduğunda T türündeki verilere erişim sağlamak için hazırlanmaktadır.
        }

        public void Delete(T p)
        {
            
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();

            //_object.Remove(p);
            //c.SaveChanges();    böyle bir yapıya devam etmememizin sebebi :EntityState yapısı, bir nesnenin durumunu belirlemek için kullanılır. Bu yapının kullanımı, varolan nesnelerin veritabanı durumunu güncellemek veya silmek gibi işlemler için daha uygundur.
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter); //sadece bir nesneyi döndürür. mesela ıd'si 1 olan (birincil anahtar olanlar), kişileri döndürür.
            //bunu silme işlemini gerçekleştirmek için yazdık çünkü neleri secebileceğimizi görüp onları silmemiz gerekir.
        }

        public void Insert(T p)
        {
            
            var addedEntity = c.Entry(p);

            addedEntity.State = EntityState.Added;
            c.SaveChanges();


            //_object.Add(p);
            //c.SaveChanges();    böyle bir yapıya devam etmememizin sebebi :EntityState yapısı, bir nesnenin durumunu belirlemek için kullanılır. Bu yapının kullanımı, varolan nesnelerin veritabanı durumunu güncellemek veya silmek gibi işlemler için daha uygundur.
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList(); //komple listeyi döndürür. yazar adı ali olanları döndür dediğimizde tüm alileri verir.
        }



        public void Update(T p)
        {
            var updateEntity = c.Entry(p);
            updateEntity.State = EntityState.Modified; //biçimlendir demek update yerine kullanılır.
            c.SaveChanges();
        }
    }
}
