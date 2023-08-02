﻿using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using ZabbixApi.Helper;

namespace Zabbix.Services.CrudServices
{
    //TODO: Maybe add createOrupdate methods
    public interface ICrudService<TEntity, TEntityInclude, TEntityProperty> : ICreate<TEntity>, IGet<TEntity, TEntityInclude, TEntityProperty>, IUpdate<TEntity>, IDelete<TEntity>
    where TEntity : IBaseEntitiy
    where TEntityInclude : struct, Enum
    where TEntityProperty : Enum
    {

    }

    public abstract class CrudService<TEntity, TEntityInclude, TEntityProperty, TEntityResult> : ServiceBase<TEntity, TEntityInclude, TEntityProperty>, ICrudService<TEntity, TEntityInclude, TEntityProperty>
        where TEntity : IBaseEntitiy
        where TEntityInclude : struct, Enum
        where TEntityResult : BaseResult
        where TEntityProperty : Enum
    {

        public CrudService(ICore core, string className) : base(core, className) { }




        #region Get

        public virtual IEnumerable<TEntity> Get(RequestFilter<TEntityProperty, TEntityInclude> filter, Dictionary<string, object> @params = null)
        {
            return base.Get(filter, @params);
        }

        public async Task<IReadOnlyList<TEntity>> GetAsync(RequestFilter<TEntityProperty, TEntityInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return await base.GetAsync(filter, @params);
        }

        #endregion

        #region Create

        public virtual IEnumerable<string> Create(IEnumerable<TEntity> entities)
        {

            Check.EnumerableNotNullOrEmpty(entities);
            return Core.SendRequest<TEntityResult>(entities, ClassName + ".create").Ids;
        }

        public virtual string Create(TEntity entity)
        {
            Check.NotNull(entity, "entity");
            return Create(new List<TEntity>() { entity }).FirstOrDefault();

        }

        public virtual Task<IReadOnlyList<string>> CreateAsync(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }
        public virtual Task<string> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Update

        public virtual IEnumerable<string> Update(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public virtual string Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public virtual Task<IReadOnlyList<string>> UpdateAsync(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }
        public virtual Task<string> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Delete

        public virtual IEnumerable<string> Delete(IEnumerable<string> ids)
        {
            throw new NotImplementedException();
        }

        public string Delete(string id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<string> Delete(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public virtual string Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IReadOnlyList<string>> DeleteAsync(IEnumerable<string> ids)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }


        public virtual Task<IReadOnlyList<string>> DeleteAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public virtual Task<string> DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
