using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemorableExtensions
{
  static class MemorableExtensionsClass
  {
    public static void Do<TControl>(this TControl control, Action<TControl> action) where TControl : System.Windows.Forms.Control
    {
      if (control.InvokeRequired) control.Invoke(action, control);
      else action(control);
    }

    public static bool InsituMap<T>(this List<T> l, Func<T, T> f)
    {
      try
      {
        for (int i = 0; i < l.Count(); i++)
        {
          l[i] = f(l[i]);
        }

        return true;
      }
      catch (Exception ex)
      {
        ex.ToString();
        return false;
      }
    }

    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> data, Func<T, bool> predicate)
    {
      foreach (T value in data)
      {
        if (predicate(value)) yield return value;
      }
    }
  }
}
