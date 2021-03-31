using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StudentTabApp
{    
    public class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(name != value)
                {
                    name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string adress;
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                if(adress != value)
                {
                    adress = value;
                    NotifyPropertyChanged();
                }

            }
        }
        private DateTime birthDate;
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                if(birthDate != value)
                {
                    birthDate = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private string schoolClass;
        public string Class
        {
            get
            {
                return schoolClass;
            }
            set
            {
                if(schoolClass != value)
                {
                    schoolClass = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private int classNo;
        public int ClassNo
        {
            get
            {
                return classNo;
            }
            set
            {
                if (classNo != value)
                {
                    classNo = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private bool likeMath;
        public bool LikeMath
        {
            get
            {
                return likeMath;
            }
            set
            {
                if(likeMath != value)
                {
                    likeMath = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private bool likeCs;
        public bool LikeCs
        {
            get
            {
                return likeCs;
            }
            set
            {
                if(likeCs != value)
                {
                    likeCs = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
