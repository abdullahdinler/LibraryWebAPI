using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Library.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public CustomResponseDto()
        {
            Errors = new List<string>();
        }
        public T Result { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }


        public static CustomResponseDto<T> Success(T result, int statusCode = 200)
        {
            return new CustomResponseDto<T>() {Result = result, StatusCode = statusCode, Errors = null};
        }

        public static CustomResponseDto<T> Success(int statusCode = 200)
        {
            return new CustomResponseDto<T>() {StatusCode = statusCode};
        }

        public static CustomResponseDto<T> Fail(List<string> errors, int statusCode = 400)
        {
            return new CustomResponseDto<T>() {Errors = errors, StatusCode = statusCode};
        }

        public static CustomResponseDto<T> Fail(string error, int statusCode = 400)
        {
            return new CustomResponseDto<T>() { Errors = new List<string>() { error}, StatusCode = statusCode};
        }
    }
}
