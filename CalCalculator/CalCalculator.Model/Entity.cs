using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculator.Model
{
    public abstract class Entity<EId> : IEquatable<Entity<EId>>
    {
        protected Entity(EId id)
        {
            if (object.Equals(id, default(EId)))
            {
                throw new ArgumentException(
                "The ID cannot be the default value.", "id");
            }
            this.Id = id;
        }
        public override bool Equals(object obj)
        {
            var entity = obj as Entity<EId>;
            if (entity != null)
            {
                return Equals(entity);
            }
            return base.Equals(obj);
        }

        public virtual bool Equals(Entity<EId> other)
        {
            if (other == null)
            {
                return false;
            }
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public EId Id { get; set; }
    }
}
