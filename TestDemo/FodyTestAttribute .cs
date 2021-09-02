using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace TestDemo
{
    [AttributeUsage(AttributeTargets.All)]
    public class FodyTestAttribute : Attribute
    {
        protected object InitInstance;

        protected MethodBase InitMethod;

        protected Object[] Args;

        public void Init(object instance, MethodBase method, object[] args)
        {
            InitMethod = method;
            InitInstance = instance;
            Args = args;
        }

        public void OnEntry()
        {
            Console.WriteLine("Before");
        }
        public void OnExit()
        {
            Console.WriteLine("After");
        }

        public void OnException(Exception exception)
        {
        }
    }
    //记住是属性
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; //实现这个玩意就行了
        [DoNotNotify] //不需要注册的
        public string GivenNames { get; set; }

        [DependsOn("GivenName", "FamilyName")] //依赖属性
        public string FamilyName { get; set; }
        public string FullName => $"{GivenNames} {FamilyName}";

    }
}
