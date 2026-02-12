using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasCSharp.Tareas
{
    public class ConversionesUnidadesAlm
    {
        public float BytesAKB(float bytes)
        {
            float kb = bytes / 1024;
            return kb;
        }

        public float BytesAMB(float bytes)
        {
            float mb = bytes / (1024 * 1024);
            return mb;
        }

        public float BytesAGB(float bytes)
        {
            float gb = bytes / (1024 * 1024 * 1024);
            return gb;
        }

        public float BytesATB(float bytes)
        {
            float tb = bytes / (1024f * 1024 * 1024 * 1024);
            return tb;
        }

        public float KBABytes(float kb)
        {
            return kb * 1024;
        }

        public float MBABytes(float mb)
        {
            return mb * 1024 * 1024;
        }

        public float GBABytes(float gb)
        {
            return gb * 1024 * 1024 * 1024;
        }

        public float TBABytes(float tb)
        {
            return tb * 1024 * 1024 * 1024 * 1024;
        }
    }
}