export const RECEIVE_CATEGORIES_TREE = 'RECEIVE_CATEGORIES_TREE';
export const RECEIVE_CATEGORY_TREE = 'RECEIVE_CATEGORY_TREE';


const initialState = {
  categoriesTree: [],
  categoryTree: []
}

function categoriesReducer(state = initialState, action) {
  switch (action.type) {
    case RECEIVE_CATEGORIES_TREE: {
      return Object.assign({}, state, {
        categoriesTree: action.data
      });
    }
    case RECEIVE_CATEGORY_TREE: {
      return Object.assign({}, state, {
        categoryTree: action.data
      });
    }
    default: {
      return state;
    }
  }
}

export default categoriesReducer;