using System.Runtime.CompilerServices;
using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class OrderItemService : IOrderItemService
{

    private IOrderItemRepository _order_itemRepository;


    private IMapper _mapper;

    public OrderItemService(IOrderItemRepository orderitemRepository, IMapper mapper)
    {
        _order_itemRepository = orderitemRepository;
        _mapper = mapper;
    }


    public List<OrderItemReadDto> GetAll()
    {

        var orderItems = _order_itemRepository.GetAll();
        var order_itemRead = orderItems.Select(_mapper.Map<OrderItemReadDto>);
        return order_itemRead.ToList();


    }





    //     public IEnumerable<OrderItem> CreateOne(OrderItem order_item)
    //     {

    //  return order_item;

    //     }


    // public OrderItem CreateOne(OrderItemCreateDto order_item){
    //     var order=new Order();
    //     foreach (OrderItemCreateDto order_item in )
    //     {

    //     }


    // }

    public OrderItem CreateOne(OrderItemCreateDto order_item)
    {
        var orderItem = new OrderItem();

        return orderItem;
    }





    // public IEnumerable<OrderItem> DeleteOne(Guid id)
    // {

    //     return _order_itemRepository.DeleteOne(id);
    // }

    public OrderItemReadDto FindOne(Guid id)
    {
        var orderItem = _order_itemRepository.FindOne(id);
        var orderItemtRead = _mapper.Map<OrderItemReadDto>(orderItem);
        return orderItemtRead;
    }


}

