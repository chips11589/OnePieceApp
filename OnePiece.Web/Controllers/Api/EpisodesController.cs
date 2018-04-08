﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnePiece.Web.Data;
using OnePiece.Web.Data.Entities;
using OnePiece.Web.Models;

namespace OnePiece.Web.Controllers.Api
{
    [Route("api/[controller]")]
    public class EpisodesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public EpisodesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> ListBySeason(int seasonId)
        {
            var eps = await _dbContext.Episodes.Where(x => x.SeasonId == seasonId)
                .Include(x => x.Medias)
                .ToListAsync();

            return Json(eps);
        }

        [HttpGet]
        public async Task<IActionResult> ListTvSpecials(ListRequest rq)
        {
            var eps = await _dbContext.Episodes.Where(x => x.Type == AnimeType.TvSpecial)
                .Include(x => x.Medias)
                .Skip(rq.Skip).Take(rq.Take).ToListAsync();

            return Json(eps);
        }

        [HttpGet]
        public async Task<IActionResult> ListMovies(ListRequest rq)
        {
            var eps = await _dbContext.Episodes.Where(x => x.Type == AnimeType.Movie)
                .Include(x => x.Medias)
                .Skip(rq.Skip).Take(rq.Take).ToListAsync();

            return Json(eps);
        }
    }
}
