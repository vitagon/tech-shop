import { ADD_FILTER_TO_APPLY } from './../reducers/productsFiltersReducer';

export function addFilterToApply(filterKey, filterValue) {
  return function (dispatch) {
    dispatch({
      type: ADD_FILTER_TO_APPLY,
      filterKey: filterKey,
      filterValue: filterValue
    })
  }
}