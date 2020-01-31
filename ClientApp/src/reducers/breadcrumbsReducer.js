export const RECEIVE_BREADCRUMBS_FOR_CATEGORY = 'RECEIVE_BREADCRUMBS_FOR_CATEGORY';

const initialState = {
  breadcrumbs: null
}

function breadcrumbsReducer(state = initialState, action) {
  switch (action.type) {
    case RECEIVE_BREADCRUMBS_FOR_CATEGORY: {
      return Object.assign({}, state, { breadcrumbs: action.data });
    }
    default: {
      return state;
    }
  }
}

export default breadcrumbsReducer;