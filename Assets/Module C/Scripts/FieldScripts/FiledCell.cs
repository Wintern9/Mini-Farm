using UnityEngine;

/// <summary>
/// ƒанные о позиции каждой клетки
/// </summary>
public class FieledCellInfo
{
    public int idCell {  get; set; }
    public Vector3 cellPosition {  get; set; }
}


/// <summary>
/// ¬ходные данные. Id клетки в которой находитьс€ гр€дка стадии stage
/// </summary>
public class SetFieldCellBedInfo
{
    public int idCell { get; set; }
    public int stage { get; set; }
}

