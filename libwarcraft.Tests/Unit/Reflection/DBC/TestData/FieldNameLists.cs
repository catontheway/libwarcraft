﻿using Warcraft.DBC.Definitions;

namespace libwarcraft.Tests.Unit.Reflection.DBC.TestData
{
    public class FieldNameLists
    {
        public static readonly string[] SingleMovedFieldNamesBeforeMove =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecordWithSingleMovedField.FieldA),
            nameof(TestDBCRecordWithSingleMovedField.FieldB),
            nameof(TestDBCRecordWithSingleMovedField.FieldC)
        };

        public static readonly string[] SingleMovedFieldBCAfterMove =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecordWithSingleMovedField.FieldC),
            nameof(TestDBCRecordWithSingleMovedField.FieldA),
            nameof(TestDBCRecordWithSingleMovedField.FieldB)
        };

        public static readonly string[] SingleMovedFieldWrathAfterMove =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecordWithSingleMovedField.FieldA),
            nameof(TestDBCRecordWithSingleMovedField.FieldC),
            nameof(TestDBCRecordWithSingleMovedField.FieldB)
        };

        public static readonly string[] MultiMovedFieldsBeforeMove =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldA),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldB),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldC),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldD),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldE),
        };

        public static readonly string[] MultiMovedFieldsBCAfterMove =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldC),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldA),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldE),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldB),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldD),
        };

        public static readonly string[] MultiMovedFieldsWrathAfterMove =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldD),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldC),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldA),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldE),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldB),
        };

        public static readonly string[] SingleMovedFieldRecordNamesMovingFields =
        {
            nameof(TestDBCRecordWithSingleMovedField.FieldC)
        };

        public static readonly string[] SimpleMoveDependencyChainFieldC =
        {
            nameof(DBCRecord.ID)
        };

        public static readonly string[] MultiMoveBCDependencyChainFieldC =
        {
            nameof(DBCRecord.ID)
        };

        public static readonly string[] MultiMoveBCDependencyChainFieldE =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldC),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldA),
        };

        public static readonly string[] MultiMoveBCDependencyChainFieldA =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldC)
        };

        public static readonly string[] MultiMoveWrathDependencyChainFieldD =
        {
            nameof(DBCRecord.ID)
        };

        public static readonly string[] MultiVersionDependencyChainFieldE =
        {
            nameof(DBCRecord.ID)
        };

        public static readonly string[] VersionedArrayRecordNames =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecordWithVersionedArray.VersionedArray)
        };

        public static readonly string[] TestRecordPropertyNames =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecord.TestSimpleField),
            nameof(TestDBCRecord.TestAddedAndRemovedField),
            nameof(TestDBCRecord.TestForeignKeyField),
            nameof(TestDBCRecord.TestNewFieldInWrath),
        };

        public static readonly string[] TestRecordClassicPropertyNames =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecord.TestSimpleField),
            nameof(TestDBCRecord.TestAddedAndRemovedField),
            nameof(TestDBCRecord.TestForeignKeyField),
        };

        public static readonly string[] TestRecordCataPropertyNames =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecord.TestSimpleField),
            nameof(TestDBCRecord.TestForeignKeyField),
            nameof(TestDBCRecord.TestNewFieldInWrath),
        };

        public static readonly string[] TestRecordWithArrayPropertyNames =
        {
            nameof(DBCRecord.ID),
            nameof(TestDBCRecordWithArray.SimpleField),
            nameof(TestDBCRecordWithArray.ArrayField)
        };

        public static readonly string[] MultipleMovedFieldRecordNamesMovingFieldsBC =
        {
            nameof(TestDBCRecordWithMultipleMovedFields.FieldA),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldC),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldE),
        };

        public static readonly string[] MultipleMovedFieldRecordNamesMovingFieldsWrath =
        {
            nameof(TestDBCRecordWithMultipleMovedFields.FieldA),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldC),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldD),
            nameof(TestDBCRecordWithMultipleMovedFields.FieldE)
        };
    }
}
