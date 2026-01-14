using System.ComponentModel.DataAnnotations;

namespace PrivateHospital.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Specialization { get; set; }

        public string Phone { get; set; }
    }
    /*
     public enum Specialization
    {
    Cardiologist_হৃদরোগ_বিশেষজ্ঞ
    Neurologist_স্নায়ু_বিশেষজ্ঞ
    Orthopedic_Surgeon_হাড়_ও_জয়েন্ট_বিশেষজ্ঞ
    Pediatrician_শিশু_রোগ_বিশেষজ্ঞ
    Dermatologist_চর্মরোগ_বিশেষজ্ঞ
    Gynecologist_স্ত্রীরোগ_বিশেষজ্ঞ
    Oncologist_ক্যানসার_বিশেষজ্ঞ
    Psychiatrist_মানসিক_রোগ_বিশেষজ্ঞ
    ENT_Specialist_কান_নাক_ও_গলা_বিশেষজ্ঞ
    Urologist_মূত্রনালী_ও_কিডনি_বিশেষজ্ঞ
    Gastroenterologist_পরিপাকতন্ত্র_বিশেষজ্ঞ
    Endocrinologist_হরমোন_ও_গ্রন্থি_বিশেষজ্ঞ
   Ophthalmologist_চোখের_ডাক্তার
   Nephrologist_কিডনি_বিশেষজ্ঞ
   General_Physician_সাধারণ রোগের ডাক্তা
    }
     */
}
