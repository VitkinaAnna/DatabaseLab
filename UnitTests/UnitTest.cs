using Xunit;
using Database5;

public class UnitTest
{
    [Fact]
    public void RenameColumn_ColumnIsRenamed_NameIsUpdated()
    {
        // Arrange
        var manager = new DBManager();
        manager.CreateDB("TestDB");
        manager.AddTable("TestTable");
        manager.AddColumn(0, "OldColumnName", "String");

        // Act
        bool result = manager.RenameColumn(0, 0, "NewColumnName");

        // Assert
        Assert.True(result);
        var table = manager.GetTable(0);
        Assert.Equal("NewColumnName", table.TableColumnsList[0].ColumnName);
    }

    [Fact]
    public void ChangeValue_IntColumnTypeTriesToSetString_ValueRemainsEmpty()
    {
        // Arrange
        var manager = new DBManager();
        manager.CreateDB("TestDB");
        manager.AddTable("TestTable");
        manager.AddColumn(0, "ColumnName", "Integer");

        // Act
        bool result = manager.ChangeValue("InvalidValue", 0, 0, 0);

        // Assert
        Assert.False(result);
        var table = manager.GetTable(0);
        Assert.Equal("", table.TableRowsList[0].RowValuesList[0]);
    }

    [Fact]
    public void DeleteColumn_RemovesColumnFromTable_ColumnIsRemoved()
    {
        // Arrange
        var manager = new DBManager();
        manager.CreateDB("TestDB");
        manager.AddTable("TestTable");
        manager.AddColumn(0, "Column1", "String");
        manager.AddColumn(0, "Column2", "Integer");

        // Act
        manager.DeleteColumn(0, 0);

        // Assert
        var table = manager.GetTable(0);
        Assert.Equal(1, table.TableColumnsList.Count);
        Assert.Equal("Column2", table.TableColumnsList[0].ColumnName);
    }

}