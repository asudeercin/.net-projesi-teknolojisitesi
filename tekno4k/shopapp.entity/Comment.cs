using System;
using System.Collections.Generic;

namespace shopapp.entity
{
public class Comment
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Content { get; set; }

    
    public int ProductId { get; set; }
    public  Product Product { get; set; }
}
}