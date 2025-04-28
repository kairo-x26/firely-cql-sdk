/*
 * Copyright (c) 2025, Firely and NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler.Expressions;

/// <seealso cref="ExpressionDef"/>
/// <seealso cref="CqlExpressionDefinitionAttribute"/>
internal class CqlExpressionDefinition
(
    LambdaExpression lambda,
    string definitionName,
    (string tagName, string[] tagValues)[] tags)
    : CqlDefinition(lambda, definitionName)
{
    public (string Name, string[] Values)[] Tags { get; } = tags;
}