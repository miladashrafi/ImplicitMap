namespace TypeConversion
{
    internal class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public static implicit operator StudentDto(Student studentDto)
        {
            return new StudentDto
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
