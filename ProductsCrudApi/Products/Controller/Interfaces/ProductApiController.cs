﻿using ProductsCrudApi.Products.Dto;
using ProductsCrudApi.Products.Model;
using Microsoft.AspNetCore.Mvc;

namespace ProductsCrudApi.Products.Controller.Interfaces;

[ApiController]
[Route("api/v1/[controller]")]
public abstract class ProductApiController:ControllerBase
{
    [HttpGet("all")]
    [ProducesResponseType(statusCode: 200, type: typeof(List<Product>))]
    [ProducesResponseType(statusCode: 404, type: typeof(String))]
    public abstract Task<ActionResult<IEnumerable<Product>>> GetProducts();

    [HttpPost("create")]
    [ProducesResponseType(statusCode: 200, type: typeof(Product))]
    [ProducesResponseType(statusCode: 400, type: typeof(String))]
    public abstract Task<ActionResult<Product>> CreateProduct([FromBody] CreateProductRequest productRequest);

    [HttpPut("update")]
    [ProducesResponseType(statusCode: 200, type: typeof(Product))]
    [ProducesResponseType(statusCode: 400, type: typeof(String))]
    [ProducesResponseType(statusCode: 404, type: typeof(String))]
    public abstract Task<ActionResult<Product>> UpdateProduct([FromQuery] int id,[FromBody] UpdateProductRequest productRequest);

    [HttpDelete("delete/{id}")]
    [ProducesResponseType(statusCode: 200, type: typeof(Product))]
    [ProducesResponseType(statusCode: 404, type: typeof(String))]
    public abstract Task<ActionResult<Product>> DeleteProduct([FromRoute] int id);
}
