﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FreeSql.Internal.CommonProvider {

	abstract class Select5Provider<T1, T2, T3, T4, T5> : Select0Provider<ISelect<T1, T2, T3, T4, T5>, T1>, ISelect<T1, T2, T3, T4, T5>
			where T1 : class
			where T2 : class
			where T3 : class
			where T4 : class
			where T5 : class {

		public Select5Provider(IFreeSql orm, CommonUtils commonUtils, CommonExpression commonExpression, object dywhere) : base(orm, commonUtils, commonExpression, dywhere) {
			if (_orm.CodeFirst.IsAutoSyncStructure) _orm.CodeFirst.SyncStructure(typeof(T2), typeof(T3), typeof(T4), typeof(T5));
		}

		TMember ISelect<T1, T2, T3, T4, T5>.Avg<TMember>(Expression<Func<T1, T2, T3, T4, T5, TMember>> column) => this.InternalAvg<TMember>(column?.Body);

		Task<TMember> ISelect<T1, T2, T3, T4, T5>.AvgAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, TMember>> column) => this.InternalAvgAsync<TMember>(column?.Body);

		ISelectGrouping<TKey> ISelect<T1, T2, T3, T4, T5>.GroupBy<TKey>(Expression<Func<T1, T2, T3, T4, T5, TKey>> exp) => this.InternalGroupBy<TKey>(exp?.Body);

		TMember ISelect<T1, T2, T3, T4, T5>.Max<TMember>(Expression<Func<T1, T2, T3, T4, T5, TMember>> column) => this.InternalMax<TMember>(column?.Body);

		Task<TMember> ISelect<T1, T2, T3, T4, T5>.MaxAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, TMember>> column) => this.InternalMaxAsync<TMember>(column?.Body);

		TMember ISelect<T1, T2, T3, T4, T5>.Min<TMember>(Expression<Func<T1, T2, T3, T4, T5, TMember>> column) => this.InternalMin<TMember>(column?.Body);

		Task<TMember> ISelect<T1, T2, T3, T4, T5>.MinAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, TMember>> column) => this.InternalMinAsync<TMember>(column?.Body);

		ISelect<T1, T2, T3, T4, T5> ISelect<T1, T2, T3, T4, T5>.OrderBy<TMember>(Expression<Func<T1, T2, T3, T4, T5, TMember>> column) => this.InternalOrderBy(column?.Body);

		ISelect<T1, T2, T3, T4, T5> ISelect<T1, T2, T3, T4, T5>.OrderByDescending<TMember>(Expression<Func<T1, T2, T3, T4, T5, TMember>> column) => this.InternalOrderByDescending(column?.Body);

		TMember ISelect<T1, T2, T3, T4, T5>.Sum<TMember>(Expression<Func<T1, T2, T3, T4, T5, TMember>> column) => this.InternalSum<TMember>(column?.Body);

		Task<TMember> ISelect<T1, T2, T3, T4, T5>.SumAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, TMember>> column) => this.InternalSumAsync<TMember>(column?.Body);

		TReturn ISelect<T1, T2, T3, T4, T5>.ToAggregate<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, ISelectGroupingAggregate<T4>, ISelectGroupingAggregate<T5>, TReturn>> select) => this.InternalToAggregate<TReturn>(select?.Body);

		Task<TReturn> ISelect<T1, T2, T3, T4, T5>.ToAggregateAsync<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, ISelectGroupingAggregate<T4>, ISelectGroupingAggregate<T5>, TReturn>> select) => this.InternalToAggregateAsync<TReturn>(select?.Body);

		List<TReturn> ISelect<T1, T2, T3, T4, T5>.ToList<TReturn>(Expression<Func<T1, T2, T3, T4, T5, TReturn>> select) => this.InternalToList<TReturn>(select?.Body);

		Task<List<TReturn>> ISelect<T1, T2, T3, T4, T5>.ToListAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, TReturn>> select) => this.InternalToListAsync<TReturn>(select?.Body);

		DataTable ISelect<T1, T2, T3, T4, T5>.ToDataTable<TReturn>(Expression<Func<T1, T2, T3, T4, T5, TReturn>> select) => this.InternalToDataTable(select?.Body);

		Task<DataTable> ISelect<T1, T2, T3, T4, T5>.ToDataTableAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, TReturn>> select) => this.InternalToDataTableAsync(select?.Body);

		string ISelect<T1, T2, T3, T4, T5>.ToSql<TReturn>(Expression<Func<T1, T2, T3, T4, T5, TReturn>> select) => this.InternalToSql<TReturn>(select?.Body);

		ISelect<T1, T2, T3, T4, T5> ISelect<T1, T2, T3, T4, T5>.Where(Expression<Func<T1, T2, T3, T4, T5, bool>> exp) => this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null));

		ISelect<T1, T2, T3, T4, T5> ISelect<T1, T2, T3, T4, T5>.WhereIf(bool condition, Expression<Func<T1, T2, T3, T4, T5, bool>> exp) => condition ? this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null)) : this;

		bool ISelect<T1, T2, T3, T4, T5>.Any(Expression<Func<T1, T2, T3, T4, T5, bool>> exp) => this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null)).Any();

		Task<bool> ISelect<T1, T2, T3, T4, T5>.AnyAsync(Expression<Func<T1, T2, T3, T4, T5, bool>> exp) => this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null)).AnyAsync();
	}
}