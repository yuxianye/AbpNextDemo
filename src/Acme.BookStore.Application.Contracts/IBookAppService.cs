using System;
using Volo.Abp.Account;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace Acme.BookStore
{
    public interface IBookAppService :
         ICrudAppService< //定义了CRUD方法
             BookDto, //用来展示书籍
             Guid, //Book实体的主键
             PagedAndSortedResultRequestDto, //获取书籍的时候用于分页和排序
             CreateUpdateBookDto, //用于创建书籍
             CreateUpdateBookDto> //用于更新书籍
    {

    }
}
