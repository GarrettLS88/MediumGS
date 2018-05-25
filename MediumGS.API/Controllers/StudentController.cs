using MediumGS.Data.Abstract;
using MediumGS.Data.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MediumGS.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/student")]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        
        // GET: api/v1/student
        [HttpGet]
        public IEnumerable<Student> GetAll()
        {
            Student student = new Student()
            {
                EnrollmentDate = DateTime.Today,
                FirstMidName = "Garrett Lee",
                LastName = "Shipp"
            };
            _studentRepository.Insert(student);

            return _studentRepository.GetAll();
        }

        // GET: api/v1/student/{id}
        [HttpGet("{id}", Name = "GetSingleStudent")]
        public IActionResult GetSinle(int id)
        {
            Student entry = _studentRepository.GetSingle(id);

            if (entry != null) return Ok(entry);

            return NotFound();
        }

        // POST: api/v1/student
        [HttpPost]
        public IActionResult Create([FromBody] Student entry)
        {
            if (entry == null) return BadRequest();

            _studentRepository.Insert(entry);

            return CreatedAtRoute("GetSingleStudent", new { id = entry.Id }, entry);
        }

        // PUT: api/v1/student
        [HttpPut]
        public IActionResult Update([FromBody] Student entry)
        {
            if (entry == null || entry.Id == 0) return BadRequest();

            _studentRepository.Update(entry);

            return NoContent();
        }

        // DELETE: api/v1/student/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _studentRepository.Delete(id);

            return NoContent();
        }
    }
}