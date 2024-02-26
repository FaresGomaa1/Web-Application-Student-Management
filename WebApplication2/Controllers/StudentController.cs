using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication2.Model;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _studentService;

        public StudentController(IStudent studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var students = _studentService.GetAll();
                return Ok(students);
            }
            catch    (Exception ex) 
            {
                return BadRequest(ex.Message);  
            }
              
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new {msg=$"{ModelState}"});
            }
                _studentService.AddStudent(student);
                return Ok(new {msg="Student added"});
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest("ID in URL does not match ID in the body.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
                _studentService.UpdateStudent(student);
                return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
                _studentService.DeleteStudent(id);
                return Ok();
        }
    }
}