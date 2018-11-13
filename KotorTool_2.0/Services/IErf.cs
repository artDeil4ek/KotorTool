﻿namespace KotorTool_2._0.Services
{
    public interface IErf
    {
        byte[] GetErfResource(int index);
        byte[] GetErfResource(string resRef, int resType);
        byte[] GetErftpcResourceHeader(int index);
        int FindIndexForResRef(string resRef, int resType);
    }
}