export const ADD_FILTER_TO_APPLY = 'ADD_FILTER_TO_APPLY';

const initialState = {
  filters: [],
  filtersToApply: {}
}

function productsFiltersReducer(state = initialState, action) {
  switch (action.type) {
    case ADD_FILTER_TO_APPLY: {
      let filtersToApply = Object.assign({}, state.filtersToApply, {
        [action.filterKey]: action.filterValue
      });
      return Object.assign({}, state, {
        filtersToApply: filtersToApply
      });
    }
    default: {
      return state;
    }
  }
}

export default productsFiltersReducer;