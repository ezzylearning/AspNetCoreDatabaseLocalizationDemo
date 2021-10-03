using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreDatabaseLocalizationDemo.Data;
using AspNetCoreDatabaseLocalizationDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreDatabaseLocalizationDemo.Services
{
    public class LocalizationService : ILocalizationService
    {
        private readonly MyAppDbContext _context;

        public LocalizationService(MyAppDbContext context)
        {
            _context = context;
        }

        public StringResource GetStringResource(string resourceKey, int languageId)
        {
            return _context.StringResources.FirstOrDefault(x => 
                    x.Name.Trim().ToLower() == resourceKey.Trim().ToLower() 
                    && x.LanguageId == languageId);
        }
    }
}
