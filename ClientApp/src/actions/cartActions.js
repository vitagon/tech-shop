import {
  ADD_ITEM_TO_CART,
  DELETE_ITEM_FROM_CART,
  SET_RAW_ITEM_QUANTITY,
  SET_ITEM_QUANTITY,
  DECREMENT_ITEM_QUANTITY,
  INCREMENT_ITEM_QUANTITY,
  COUNT_ITEMS,
  COUNT_ITEMS_TOTAL
} from './../reducers/cartReducer';

export function addItemToCart(product) {
  return async function(dispatch) {
    await dispatch({
      type: ADD_ITEM_TO_CART,
      data: product,
      receivedAt: Date.now()
    });
    await dispatch({ type: COUNT_ITEMS, receivedAt: Date.now() });
    await dispatch({ type: COUNT_ITEMS_TOTAL, receivedAt: Date.now() });
  }
}

export function deleteItemFromCart(item) {
  return async function (dispatch) {
    await dispatch({
      type: DELETE_ITEM_FROM_CART,
      data: item.product.id,
      receivedAt: Date.now()
    })
    await dispatch({ type: COUNT_ITEMS, receivedAt: Date.now() });
    await dispatch({ type: COUNT_ITEMS_TOTAL, receivedAt: Date.now() });
  }
}

export function setRawItemQuantity(item, qty) {
  return function (dispatch) {
    dispatch({
      type: SET_RAW_ITEM_QUANTITY,
      data: {
        id: item.product.id,
        qty: qty
      },
      receivedAt: Date.now()
    })
  }
}

export function setItemQuantity(item, qty) {
  return async function (dispatch) {
    await dispatch({
      type: SET_ITEM_QUANTITY,
      data: {
        id: item.product.id,
        qty: qty
      },
      receivedAt: Date.now()
    })
    await dispatch({ type: COUNT_ITEMS, receivedAt: Date.now() });
    await dispatch({ type: COUNT_ITEMS_TOTAL, receivedAt: Date.now() });
  }
}

export function decrementItemQuantity(item) {
  return async function (dispatch) {
    await dispatch({
      type: DECREMENT_ITEM_QUANTITY,
      data: item.product.id,
      receivedAt: Date.now()
    })
    await dispatch({ type: COUNT_ITEMS, receivedAt: Date.now() });
    await dispatch({ type: COUNT_ITEMS_TOTAL, receivedAt: Date.now() });
  }
}

export function incrementItemQuantity(item) {
  return async function (dispatch) {
    await dispatch({
      type: INCREMENT_ITEM_QUANTITY,
      data: item.product.id,
      receivedAt: Date.now()
    })
    await dispatch({ type: COUNT_ITEMS, receivedAt: Date.now() });
    await dispatch({ type: COUNT_ITEMS_TOTAL, receivedAt: Date.now() });
  }
}