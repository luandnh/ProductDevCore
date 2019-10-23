using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsAuthorizationService.ViewModels
{
    public partial interface IViewModel
    {
        void CopyFrom(object src);
        void CopyTo(object dest);
        Entity To<Entity>();
    }
    public partial interface IBaseViewModel<E> : IViewModel
    {
        void FromEntity(E Entity);
        E ToEntity();
    }
    public abstract partial class BaseViewModel<E> : IBaseViewModel<E>
    {
        protected E Entity { get; set; }
        public BaseViewModel() { }
        public BaseViewModel(E entity)
        {
            FromEntity(entity);
        }
        public virtual void FromEntity(E entity)
        {
            Entity = entity;
            AMC._mapper.Map(entity, this);
        }

        public virtual E ToEntity()
        {
            if (Entity != null) return Entity;
            return AMC._mapper.Map<E>(this);
        }

        public virtual E ToEntity(bool copyToEntity)
        {
            if (Entity != null)
            {
                if (copyToEntity) CopyTo(Entity);
                return Entity;
            }
            return AMC._mapper.Map<E>(this);
        }
        public void CopyFrom(object src)
        {
            AMC._mapper.Map(src, this);
        }

        public void CopyTo(object dest)
        {
            AMC._mapper.Map(this, dest);
        }

        public Entity To<Entity>()
        {
            return AMC._mapper.Map<Entity>(this);
        }
    }
}
