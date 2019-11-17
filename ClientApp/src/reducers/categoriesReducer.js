import { RECEIVE_CATEGORIES } from '../actions/categoriesActions';
import { toggleComponent } from './util/ToggleComponent';

export const TOGGLE_ADD_CATEGORY_COMP = 'TOGGLE_ADD_CATEGORY_COMP';
export const TOGGLE_EDIT_CATEGORY_COMP = 'TOGGLE_EDIT_CATEGORY_COMP';

const initialState = {
  categories: [
    { id: 22, name: 'headphones', parentId: 0 },
    { id: 23, name: 'cellphones', parentId: 0 },
    { id: 24, name: 'video cards', parentId: 0 }
  ],
  showAddCategoryComp: false,
  showEditCategoryComp: false,
  currentCategory: {}
}

function categoriesReducer(state = initialState, action) {
  switch (action.type) {
    case RECEIVE_CATEGORIES: {
      return Object.assign({}, state, {
        categories: action.data
      });
    }
    case TOGGLE_ADD_CATEGORY_COMP: {
      if (!state.showAddCategoryComp) {
        closeAllComponents(state);
      }
      return Object.assign({}, state, {
        showAddCategoryComp: !state.showAddCategoryComp
      });
    }
    case TOGGLE_EDIT_CATEGORY_COMP: {
      let category = action.data;
      return toggleComponent(state, state.currentCategory, category, 'showEditCategoryComp', 'currentCategory', closeAllComponents);
    }
    default: {
      return state;
    }
  }
}

const closeAllComponents = (state) => {
  state.showAddCategoryComp = false;
  state.showEditCategoryComp = false;
}

export default categoriesReducer;