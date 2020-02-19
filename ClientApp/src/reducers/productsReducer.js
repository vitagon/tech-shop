export const RECEIVE_PRODUCTS = 'RECEIVE_PRODUCTS';

const initialState = {
  products: [],
  metadata: {
    TotalCount: 0,
    PageSize: 0,
    CurrentPage: 0,
    TotalPages: 0,
    HasNext: false,
    HasPrevious: false
  }
}

function productsReducer(state = initialState, action) {
  switch (action.type) {
    case RECEIVE_PRODUCTS: {
      return Object.assign({}, state, {
        products: action.data,
        metadata: action.metadata
      });
    }
    default: {
      return state;
    }
  }
}

export default productsReducer;