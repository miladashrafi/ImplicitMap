namespace TypeConversion
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public static implicit operator Student(StudentDto studentDto)
        {
            return new Student
            {
                Code = studentDto.Code,
                Id = studentDto.Id,
                Name = studentDto.Name,
            };
        }

        public override string ToString()
        {
            return $"{Name} ({Code})";
        }
    }
}
