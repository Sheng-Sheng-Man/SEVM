﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sevm.Engine {

    /// <summary>
    /// 定义集合
    /// </summary>
    public class ScriptLabels : Dictionary<int, ScriptLabel> {

        //// 自动扩展集合
        //private void AutoCreate(int index) {
        //    if (base.Count <= index) {
        //        for (int i = base.Count; i <= index; i++) {
        //            base.Add(null);
        //        }
        //    }
        //}

        ///// <summary>
        ///// 获取或设置寄存器值
        ///// </summary>
        ///// <param name="index"></param>
        ///// <returns></returns>
        //public new ScriptLabel this[int index] {
        //    get {
        //        this.AutoCreate(index);
        //        return base[index];
        //    }
        //    set {
        //        this.AutoCreate(index);
        //        base[index] = value;
        //    }
        //}

    }
}
