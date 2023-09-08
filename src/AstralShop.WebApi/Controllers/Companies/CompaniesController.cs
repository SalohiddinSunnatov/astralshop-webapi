﻿using AstralShop.Service.Interfaces.Companies;
using Microsoft.AspNetCore.Mvc;

namespace AstralShop.WebApi.Controllers.Companies;

[Route("api/companies")]
[ApiController]
public class CompaniesController : ControllerBase
{
    private readonly ICompanyService _service;

    public CompaniesController(ICompanyService service)
    {
        this._service = service;
    }

    [HttpGet("count")]
    public async Task<IActionResult> CountAsync()
        => Ok(await _service.CountAsync());
}

