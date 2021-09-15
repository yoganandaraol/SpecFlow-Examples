﻿using Microsoft.AspNetCore.Mvc;
using SpecFlowCalculator.Models;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace SpecFlowCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Calculator _calculator;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _calculator = new Calculator();
        }

        public IActionResult Index(CalculatorViewModel calculatorViewModel)
        {
            return View(calculatorViewModel);
        }

        public IActionResult Add(CalculatorViewModel calculatorViewModel)
        {
            calculatorViewModel.Result =
                _calculator.Add(calculatorViewModel.FirstNumber, calculatorViewModel.SecondNumber);

            return View("Index", calculatorViewModel);
        }

        public IActionResult Subtract(CalculatorViewModel calculatorViewModel)
        {
            calculatorViewModel.Result =
                _calculator.Subtract(calculatorViewModel.FirstNumber, calculatorViewModel.SecondNumber);

            return View("Index", calculatorViewModel);
        }

        public IActionResult Multiply(CalculatorViewModel calculatorViewModel)
        {
            calculatorViewModel.Result =
                _calculator.Multiply(calculatorViewModel.FirstNumber, calculatorViewModel.SecondNumber);

            return View("Index", calculatorViewModel);
        }

        public IActionResult Divide(CalculatorViewModel calculatorViewModel)
        {
            calculatorViewModel.Result =
                _calculator.Divide(calculatorViewModel.FirstNumber, calculatorViewModel.SecondNumber);

            return View("Index", calculatorViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}